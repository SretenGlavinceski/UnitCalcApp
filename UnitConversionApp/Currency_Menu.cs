using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;
using Newtonsoft.Json.Linq;

namespace UnitConversionApp
{
    public partial class Currency_Menu : UserControl
    {
        private Dictionary<string, double> currencies;
        public Currency_Menu()
        {
            InitializeComponent();
            currencies = new Dictionary<string, double>();
            InitializeValidCurrencies();

            if (chartExchangeRateData.ChartAreas.Count == 0)
            {
                chartExchangeRateData.ChartAreas.Add(new ChartArea("MainArea"));
            }

            from_currency_value.KeyPress += new KeyPressEventHandler(Validate_KeyPress);
            to_currency_value.KeyPress += new KeyPressEventHandler(Validate_KeyPress);
            this.from_currency_value.TextAlign = HorizontalAlignment.Left;
            this.to_currency_value.TextAlign = HorizontalAlignment.Left;

            DoubleBuffered = true;
        }

        private void Validate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void InitializeValidCurrencies()
        {
            var currencies_response = getLatestExchangeRates();
            dynamic responseObject = JsonConvert.DeserializeObject(currencies_response);

            foreach (var item in responseObject.data)
            {
                from_currency.Items.Add(item.First.code.ToString());
                to_currency.Items.Add(item.First.code.ToString());
                currencies.Add(item.First.code.ToString(), item.First.value.Value);
            }

        }

        private string getLatestExchangeRates()
        {
            var client = new RestClient("https://api.currencyapi.com/v3/latest");

            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("apikey", "cur_live_gfqSNzfeJBoLhzgGIODw1B35ZEILCran0m7yAJDM");
            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        private void from_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            from_currency_value.Clear();
            to_currency_value.Clear();
            if (!from_currency_value.Enabled)
            {
                from_currency_value.Enabled = true;
            }
            from_currency_label.Text = from_currency.SelectedItem.ToString();
        }

        private void to_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            from_currency_value.Clear();
            to_currency_value.Clear();
            if (!to_currency_value.Enabled)
            {
                to_currency_value.Enabled = true;
            }
            to_currency_label.Text = to_currency.SelectedItem.ToString();
        }

        private void from_currency_value_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(from_currency_value.Text))
            {
                to_currency_value.Clear();
                return;
            }

            if (to_currency.SelectedIndex == -1)
            {
                return;
            }

            var selectedSourceCurrency = from_currency.SelectedItem.ToString();
            var selectedConvertCurrency = to_currency.SelectedItem.ToString();

            if (double.TryParse(from_currency_value.Text, out double amount))
            {
                var sourceCurrencyExchangeRate = currencies[selectedSourceCurrency];
                var convertToCurrencyExchangeRate = currencies[selectedConvertCurrency];

                var calculatedAmount = (amount / sourceCurrencyExchangeRate) * convertToCurrencyExchangeRate;

                to_currency_value.Text = calculatedAmount.ToString("F2");
            }
        }

        private void to_currency_value_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(to_currency_value.Text))
            {
                from_currency_value.Clear();
                return;
            }

            if (from_currency.SelectedIndex == -1)
            {
                return;
            }

            var selectedSourceCurrency = to_currency.SelectedItem.ToString();
            var selectedConvertCurrency = from_currency.SelectedItem.ToString();

            if (double.TryParse(to_currency_value.Text, out double amount))
            {
                var sourceCurrencyExchangeRate = currencies[selectedSourceCurrency];
                var convertToCurrencyExchangeRate = currencies[selectedConvertCurrency];

                var calculatedAmount = (amount / sourceCurrencyExchangeRate) * convertToCurrencyExchangeRate;

                from_currency_value.Text = calculatedAmount.ToString("F2");
            }
        }

        private void save_exchange_Click(object sender, EventArgs e)
        {
            if (to_currency.SelectedIndex == -1 || from_currency.SelectedIndex == -1
                || from_currency_value.Text == "" || to_currency_value.Text == "")
            {
                MessageBox.Show("Please fill out all fields before saving!");
                return;
            }

            CurrencyExchange currencyExchangeItem =
                new CurrencyExchange(
                        from_currency.SelectedItem.ToString(),
                        to_currency.SelectedItem.ToString(),
                        double.Parse(from_currency_value.Text),
                        double.Parse(to_currency_value.Text)
                    );

            exchanges_list.Items.Add(currencyExchangeItem);

        }

        private Dictionary<string, double> getHistoricalExchangeRates(string fromCurrency, string toCurrency)
        {
            Dictionary<string, double> rates = new Dictionary<string, double>();

            for (int i = 0; i < 30; i++)
            {
                DateTime date = DateTime.Now.AddDays(-i);
                string dateString = date.ToString("yyyy-MM-dd");

                var client = new RestClient($"https://api.currencyapi.com/v3/historical?date={dateString}");

                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("apikey", "cur_live_gfqSNzfeJBoLhzgGIODw1B35ZEILCran0m7yAJDM");
                IRestResponse response = client.Execute(request);

                dynamic responseObject = JsonConvert.DeserializeObject(response.Content);

                if (responseObject != null && responseObject.data != null)
                {
                    double fromCurrencyRate = responseObject.data[fromCurrency].value;
                    double toCurrencyRate = responseObject.data[toCurrency].value;

                    double conversionRate = toCurrencyRate / fromCurrencyRate;

                    rates.Add(dateString, conversionRate);
                }
            }

            return rates;
        }

        private void DrawChart(Dictionary<string, double> historicalRates)
        {
            chartExchangeRateData.Series["Exchage Rate Graph"]
                .Points
                .DataBindXY(historicalRates.Keys, historicalRates.Values);

            chartExchangeRateData.Invalidate();
        }

        private void show_graph_Click(object sender, EventArgs e)
        {
            if (from_currency.SelectedIndex == -1 || to_currency.SelectedIndex == -1)
            {
                MessageBox.Show("Select valid Currencies!");
                return;
            }

            chartExchangeRateData.Visible = true;
            panel_hide_chart.Visible = false;
            from_to_currency_label.Visible = true;
            label_temp_hide.Visible = false;

            Dictionary<string, double> rates = getHistoricalExchangeRates(
                from_currency.SelectedItem.ToString(),
                to_currency.SelectedItem.ToString());

            from_to_currency_label.Text =
                String.Format("Exchange Rates in Last Month ({0} to {1})", from_currency.SelectedItem.ToString(), to_currency.SelectedItem.ToString());

            DrawChart(rates);
        }

        private void use_exchange_again_Click(object sender, EventArgs e)
        {
            if (exchanges_list.SelectedIndex == -1)
            {
                MessageBox.Show("Select existing exchange rate!");
                return;
            }

            CurrencyExchange currencyExchangeItem = exchanges_list.SelectedItem as CurrencyExchange;

            from_currency.SelectedItem = currencyExchangeItem.leftExchange;
            to_currency.SelectedItem = currencyExchangeItem.rightExchange;

            from_currency_value.Clear();
            to_currency_value.Clear();
        }
    }
}
