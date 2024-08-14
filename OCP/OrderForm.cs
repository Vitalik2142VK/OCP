﻿using System;

namespace OCP
{
    public class OrderForm
    {
        private PaymentSystemIdRepository _repository;

        public OrderForm(PaymentSystemIdRepository repository)
        {
            if (repository == null)
                throw new ArgumentNullException(nameof(repository));

            _repository = repository;
        }

        public void ShowForm()
        {
            string paymentSystemNames = "";

            foreach (string nameType in _repository.GetIdNames())
            {
                paymentSystemNames += nameType + "\n";
            }

            Console.WriteLine($"Мы принимаем:\n{paymentSystemNames}\n\n" +
                $"Какой системой вы хотите совершить оплату?");
        }

        public PaymentSystemId FindPaymentSystemId()
        {
            string input = Console.ReadLine();

            return _repository.FindPaymentSystemId(input);
        } 
    }
}
