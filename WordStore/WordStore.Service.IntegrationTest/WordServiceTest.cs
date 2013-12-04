using IntelliCloud.WordStore.Common.Word;
using IntelliCloud.WordStore.Data.Database.Factory;
using IntelliCloud.WordStore.Data.Database.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace IntelliCloud.WordStore.Service.IntegrationTest
{
    [TestClass]
    public class WordServiceTest
    {
        #region Fields

        private IWordService service;

        #endregion Fields

        #region Methods

        [TestInitialize]
        public void Initialize()
        {
            this.service = new WordService();
        }

        #region Tests

        [TestMethod]
        [TestCategory("IntelliCloud.Service.IntegrationTest")]
        public void Test()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var words1 = this.service.ResolveWord("show");
            stopwatch.Stop();
            Debug.WriteLine(string.Format("Found: {0} words in {1}", words1.Count(), stopwatch.ElapsedMilliseconds));

            stopwatch.Reset();

            stopwatch.Start();
            var words2 = this.service.ResolveWord("show");
            stopwatch.Stop();
            Debug.WriteLine(string.Format("Found: {0} words in {1}", words2.Count(), stopwatch.ElapsedMilliseconds));
        }

        #endregion Tests

        #endregion Methods
    }
}
