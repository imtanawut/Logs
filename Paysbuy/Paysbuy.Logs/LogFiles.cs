using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paysbuy.Logs {
    public class LogFiles {
        public String logsName { get; set; }
        public String logsDestination { get; set; }
        public LogLevel logsLevel { get; set; }
        public DateTime logsDate { get; set; }
        public Object logsRemark { get; set; }

        public LogFiles() {
            this.logsDestination = @"c:\logsfile\";
            this.logsLevel = LogLevel.info;
            this.logsDate = DateTime.Now;
        }

        public LogFiles(String name, String desctination, LogLevel level, DateTime datetime, Object remark) {
            this.logsName = name;
            this.logsDestination = desctination;
            this.logsLevel = level;
            this.logsDate = datetime;
            this.logsRemark = remark;
        }

        public void writeLogs() {

        }
    }
}
