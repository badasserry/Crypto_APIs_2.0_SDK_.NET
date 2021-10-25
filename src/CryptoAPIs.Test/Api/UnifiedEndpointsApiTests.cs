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
    ///  Class for testing UnifiedEndpointsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UnifiedEndpointsApiTests : IDisposable
    {
        private UnifiedEndpointsApi instance;

        public UnifiedEndpointsApiTests()
        {
            instance = new UnifiedEndpointsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UnifiedEndpointsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UnifiedEndpointsApi
            //Assert.IsType<UnifiedEndpointsApi>(instance);
        }

        /// <summary>
        /// Test GetAddressDetails
        /// </summary>
        [Fact]
        public void GetAddressDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string address = null;
            //string context = null;
            //var response = instance.GetAddressDetails(blockchain, network, address, context);
            //Assert.IsType<GetAddressDetailsR>(response);
        }

        /// <summary>
        /// Test GetBlockDetailsByBlockHash
        /// </summary>
        [Fact]
        public void GetBlockDetailsByBlockHashTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string blockHash = null;
            //string context = null;
            //var response = instance.GetBlockDetailsByBlockHash(blockchain, network, blockHash, context);
            //Assert.IsType<GetBlockDetailsByBlockHashR>(response);
        }

        /// <summary>
        /// Test GetBlockDetailsByBlockHeight
        /// </summary>
        [Fact]
        public void GetBlockDetailsByBlockHeightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //int height = null;
            //string context = null;
            //var response = instance.GetBlockDetailsByBlockHeight(blockchain, network, height, context);
            //Assert.IsType<GetBlockDetailsByBlockHeightR>(response);
        }

        /// <summary>
        /// Test GetFeeRecommendations
        /// </summary>
        [Fact]
        public void GetFeeRecommendationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //var response = instance.GetFeeRecommendations(blockchain, network, context);
            //Assert.IsType<GetFeeRecommendationsR>(response);
        }

        /// <summary>
        /// Test GetLastMinedBlock
        /// </summary>
        [Fact]
        public void GetLastMinedBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //var response = instance.GetLastMinedBlock(blockchain, network, context);
            //Assert.IsType<GetLastMinedBlockR>(response);
        }

        /// <summary>
        /// Test GetTransactionDetailsByTransactionID
        /// </summary>
        [Fact]
        public void GetTransactionDetailsByTransactionIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string transactionId = null;
            //string context = null;
            //var response = instance.GetTransactionDetailsByTransactionID(blockchain, network, transactionId, context);
            //Assert.IsType<GetTransactionDetailsByTransactionIDR>(response);
        }

        /// <summary>
        /// Test ListAllUnconfirmedTransactions
        /// </summary>
        [Fact]
        public void ListAllUnconfirmedTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListAllUnconfirmedTransactions(blockchain, network, context, limit, offset);
            //Assert.IsType<ListAllUnconfirmedTransactionsR>(response);
        }

        /// <summary>
        /// Test ListConfirmedTransactionsByAddress
        /// </summary>
        [Fact]
        public void ListConfirmedTransactionsByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string address = null;
            //string context = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListConfirmedTransactionsByAddress(blockchain, network, address, context, limit, offset);
            //Assert.IsType<ListConfirmedTransactionsByAddressR>(response);
        }

        /// <summary>
        /// Test ListLatestMinedBlocks
        /// </summary>
        [Fact]
        public void ListLatestMinedBlocksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //string blockchain = null;
            //int count = null;
            //string context = null;
            //var response = instance.ListLatestMinedBlocks(network, blockchain, count, context);
            //Assert.IsType<ListLatestMinedBlocksR>(response);
        }

        /// <summary>
        /// Test ListTransactionsByBlockHash
        /// </summary>
        [Fact]
        public void ListTransactionsByBlockHashTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string blockHash = null;
            //string context = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListTransactionsByBlockHash(blockchain, network, blockHash, context, limit, offset);
            //Assert.IsType<ListTransactionsByBlockHashR>(response);
        }

        /// <summary>
        /// Test ListTransactionsByBlockHeight
        /// </summary>
        [Fact]
        public void ListTransactionsByBlockHeightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //int height = null;
            //string context = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListTransactionsByBlockHeight(blockchain, network, height, context, limit, offset);
            //Assert.IsType<ListTransactionsByBlockHeightR>(response);
        }

        /// <summary>
        /// Test ListUnconfirmedTransactionsByAddress
        /// </summary>
        [Fact]
        public void ListUnconfirmedTransactionsByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string address = null;
            //string context = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListUnconfirmedTransactionsByAddress(blockchain, network, address, context, limit, offset);
            //Assert.IsType<ListUnconfirmedTransactionsByAddressR>(response);
        }
    }
}
