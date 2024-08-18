using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public class OrderForm
    {
        private IEnumerable<string> _paymentSystemIdNames;

        public OrderForm(IEnumerable<string> paymentSystemIdNames)
        {
            _paymentSystemIdNames = paymentSystemIdNames ?? throw new ArgumentNullException(nameof(paymentSystemIdNames));
        }

        public void ShowForm()
        {
            StringBuilder paymentSystemNames = new StringBuilder();

            foreach (string nameType in _paymentSystemIdNames)
            {
                paymentSystemNames.Append(nameType).Append("\n");
            }

            Console.WriteLine($"Мы принимаем:\n{paymentSystemNames}\n\n" +
                $"Какой системой вы хотите совершить оплату?");
        }

        public string ChooseSystemId()
        {
            return Console.ReadLine();
        } 
    }
}
