using System.Collections.Generic;

namespace TransactionRecording
{
    static class ApplicationDelegate
    {
        private static List<TransactionEntry> transactionList = null;
        private static List<string> departmentList = null;
        private static List<string> dateList = null;
        public static string reportGeneratorSelectedDepartment;

        public static void setTransactionList(List<TransactionEntry> _transactionList)
        {
            transactionList = _transactionList;
        }

        public static List<TransactionEntry> getTransactionList()
        {
            return (transactionList != null) ? transactionList : new List<TransactionEntry>();
        }

        public static void setDepartmentList(List<string> _departmentList)
        {
            departmentList = _departmentList;
        }

        public static List<string> getDepartmentList()
        {
            return (departmentList != null) ? departmentList : new List<string>();
        }

        public static void setDateList(List<string> _dateList)
        {
            dateList = _dateList;
        }

        public static List<string> getDateList()
        {
            return (dateList != null) ? dateList : new List<string>();
        }
    }
}
