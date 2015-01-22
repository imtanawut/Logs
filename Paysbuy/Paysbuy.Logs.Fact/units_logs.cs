using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Paysbuy.Logs;
using Xunit;

namespace Paysbuy.Logs.Fact {
    public class units_logs {
        
        [Fact]
        public void unit_test_constructor_no_parameter() {
            LogFiles logs = new LogFiles();
            Assert.Equal(LogLevel.info, logs.logsLevel);
        }

        [Fact]
        public void unit_test_constructor_with_parameter() {
            string name =@"testing";
            string dest = @"c:\tmp";
            DateTime dt = DateTime.Now.Date;
            List<String> lst = new List<string>();
            LogFiles logs = new LogFiles(name, dest, LogLevel.debug, dt, lst);

            Assert.Equal(name, logs.logsName);
            Assert.Equal(dest, logs.logsDestination);
            Assert.Equal(dt, logs.logsDate);
            Assert.Equal(lst, logs.logsRemark);
        }
    }
}
