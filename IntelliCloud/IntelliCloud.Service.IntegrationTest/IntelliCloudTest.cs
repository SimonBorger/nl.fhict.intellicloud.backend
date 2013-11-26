﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using nl.fhict.IntelliCloud.Service;
using System;

namespace nl.fhict.IntelliCloud.Service.IntegrationTest
{
    /// <summary>
    /// This class inhibits integration tests for the service <see cref="IIntelliCloudService"/>.
    /// </summary>
    [TestClass]
    public class IntelliCloudTest
    {
        #region Fields

        /// <summary>
        /// An instance of the service <see cref="IIntelliCloudService"/> that is being tested by this class.
        /// </summary>
        private IIntelliCloudService service;

        #endregion Fields

        #region Methods

        /// <summary>
        /// A method that is called before each test is run. This method is used to set up a fresh state for
        /// each test by for instance creating new service objects.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            this.service = new IntelliCloudService();
        }

        /// <summary>
        /// A method that is called after each test that is ran. This method is used to, for instance, dispose
        /// any objects that require disposing.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            //TODO: Add cleanup code or remove method.
        }

        #region Tests

        [TestMethod]
        [TestCategory("nl.fhict.IntelliCloud.Service.IntegrationTest")]
        public void GetAnswerById_InvalidAnswerId()
        {
            try
            {
                //this.service.GetAnswerById("InvalidId");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Put the expected exception message here");
            }
        }

        #endregion Tests

        #endregion Methods
    }
}
