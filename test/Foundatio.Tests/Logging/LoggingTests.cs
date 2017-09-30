﻿using System.Threading.Tasks;
using Foundatio.Logging.Xunit;
using Foundatio.Utility;
using Microsoft.Extensions.Logging;
using Xunit;
using Xunit.Abstractions;

namespace Foundatio.Tests.Logging {
    public class LoggingTests : TestWithLoggingBase {
        public LoggingTests(ITestOutputHelper output) : base(output) { }

        [Fact]
        public async Task BeginScopeProperty() {
            var logger = Log.CreateLogger<LoggingTests>();
            //using (logger.BeginScope<>(b => b.Property("prop1", "val1").Property("prop2", "val2")))
            //using (logger.BeginScope<>(b => b.Property("prop1", "innerval1"))) {
            //    logger.LogInformation("Hey {Stuff}!", "Eric");
            //    await BlahAsync(logger);
            //}

            //foreach (var entry in Log.LogEntries) {
            //    Assert.Equal(2, entry.Scopes.Length);

            //    Assert.Equal(2, entry.Properties.Count);
            //    Assert.Equal("innerval1", entry.Properties["prop1"]);
            //    Assert.Equal("val2", entry.Properties["prop2"]);
            //}
        }

        [Fact]
        public void LogBuilder() {
            var logger = Log.CreateLogger<LoggingTests>();
            //logger.LogInformation().Message(() => "hello").Write();

            //Assert.Equal(1, Log.LogEntries.Count);
            //Assert.Equal("hello", Log.LogEntries[0].Message);
        }

        [Fact]
        public void LogNullString() {
            var logger = Log.CreateLogger<LoggingTests>();
            //logger.LogInformation().Message((string)null).Property("Id", (string)null).Write();
        }

        [Fact]
        public void LogDelegate() {
            var logger = Log.CreateLogger<LoggingTests>();
            var name = "Tester";

            logger.LogInformation($"{name} at {SystemClock.UtcNow}.");
        }

        [Fact]
        public void LogException() {
            var logger = Log.CreateLogger<LoggingTests>();
            //logger.LogError().Exception(new Exception("test")).Write();
        }

        private Task BlahAsync(ILogger logger) {
            logger.LogInformation("Task hello");

            return Task.CompletedTask;
        }
    }
}
