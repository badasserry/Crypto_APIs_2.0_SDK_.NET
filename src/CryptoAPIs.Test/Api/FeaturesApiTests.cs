/*
 * CryptoAPIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: developers@cryptoapis.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using CryptoAPIs.Client;
using CryptoAPIs.Api;
// uncomment below to import models
//using CryptoAPIs.Model;

namespace CryptoAPIs.Test.Api
{
    /// <summary>
    ///  Class for testing FeaturesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FeaturesApiTests : IDisposable
    {
        private FeaturesApi instance;

        public FeaturesApiTests()
        {
            instance = new FeaturesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FeaturesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FeaturesApi
            //Assert.IsType<FeaturesApi>(instance);
        }

        /// <summary>
        /// Test BroadcastLocallySignedTransaction
        /// </summary>
        [Fact]
        public void BroadcastLocallySignedTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //BroadcastLocallySignedTransactionRB broadcastLocallySignedTransactionRB = null;
            //var response = instance.BroadcastLocallySignedTransaction(blockchain, network, context, broadcastLocallySignedTransactionRB);
            //Assert.IsType<BroadcastLocallySignedTransactionR>(response);
        }

        /// <summary>
        /// Test GenerateAddress
        /// </summary>
        [Fact]
        public void GenerateAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //GenerateAddressRB generateAddressRB = null;
            //var response = instance.GenerateAddress(blockchain, network, context, generateAddressRB);
            //Assert.IsType<GenerateAddressR>(response);
        }

        /// <summary>
        /// Test GetEIP1559FeeRecommendations
        /// </summary>
        [Fact]
        public void GetEIP1559FeeRecommendationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //string blockchain = null;
            //string context = null;
            //var response = instance.GetEIP1559FeeRecommendations(network, blockchain, context);
            //Assert.IsType<GetEIP1559FeeRecommendationsR>(response);
        }

        /// <summary>
        /// Test ValidateAddress
        /// </summary>
        [Fact]
        public void ValidateAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //ValidateAddressRB validateAddressRB = null;
            //var response = instance.ValidateAddress(blockchain, network, context, validateAddressRB);
            //Assert.IsType<ValidateAddressR>(response);
        }
    }
}
