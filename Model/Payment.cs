﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevenueMonsterOpenAPI.Model
{
    public class QuickPay
    {
        public TransactionQuickPay item { get; set; }
        public string code { get; set; }
        public Error error { get; set; }
    }

    public class Refund
    {
        public TransactionQuickPay item { get; set; }
        public string code { get; set; }
        public Error error { get; set; }
    }

    public class Reverse
    {
        public TransactionQuickPay item { get; set; }
        public string code { get; set; }
        public Error error { get; set; }
    }

    public class PaymentTransactionByID
    {
        public TransactionQuickPay item { get; set; }
        public string code { get; set; }
        public Error error { get; set; }
    }

    public class PaymentTransactionByOrderID
    {
        public TransactionQuickPay item { get; set; }
        public string code { get; set; }
        public Error error { get; set; }
    }

    public class CreateTransactionQrCodeUrl
    {
        public TransactionQR item { get; set; }
        public string code { get; set; }
        public Error error { get; set; }
    }

    public class GetTransactionQrCodeUrl
    {
        public List<TransactionQR> items { get; set; }
        public string code { get; set; }
        public Error error { get; set; }
        public Meta meta { get; set; }
    }

    public class GetTransactionQrCodeUrlByCode
    {
        public TransactionQR item { get; set; }
        public string code { get; set; }
        public Error error { get; set; }
    }

    public class GetTransactionsByCode
    {
        public List<Transaction> items { get; set; }
        public string code { get; set; }
        public Error error { get; set; }
        public Meta meta { get; set; }
    }

    public class Store
    {
        public string id { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string postCode { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string phoneNumber { get; set; }
        public GeoLocation geoLocation { get; set; }
        public string status { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }

    public class GeoLocation
    {
        public float Lat { get; set; }
        public float Lng { get; set; }
    }

    public class Order
    {
        public string id { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public string additionalData { get; set; }
        public Int64 amount { get; set; }
    }

    public class Payee
    {
        public string userId { get; set; }
    }

    public class Expiry
    {
        public string type { get; set; }
        public float day { get; set; }
        public string expiredAt { get; set; }
    }

    public class TransactionQuickPay
    {
        public Store store { get; set; }
        public string referenceId { get; set; }
        public string transactionId { get; set; }
        public Order order { get; set; }
        public string terminalId { get; set; }
        public string currencyType { get; set; }
        public Int64 balanceAmount { get; set; }
        public Payee payee { get; set; }
        public string platform { get; set; }
        public string method { get; set; }
        public Error error { get; set; }
        public string transactionAt { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string region { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }

    public class TransactionQR
    {
        public Store store { get; set; }
        public Expiry expiry { get; set; }
        public Order order { get; set; }
        public string type { get; set; }
        public bool isPreFillAmount { get; set; }
        public string currencyType { get; set; }
        public Int64 amount { get; set; }
        public string platform { get; set; }
        public List<string> method { get; set; }
        public string code { get; set; }
        public string status { get; set; }
        public string qrCodeUrl { get; set; }
        public string redirectUrl { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }

    public class Transaction
    {
        public Store store { get; set; }
        public string referenceId { get; set; }
        public string transactionId { get; set; }
        public Order order { get; set; }
        public string terminalId { get; set; }
        public string currencyType { get; set; }
        public Int64 balanceAmount { get; set; }
        public string platform { get; set; }
        public string method { get; set; }
        public Error error { get; set; }
        public string transactionAt { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string region { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }

}
