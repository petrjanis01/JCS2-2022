namespace Database
{
    public class Student
    {
        public string OsCislo { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string UserName { get; set; }
        public int Rocnik { get; set; }
        public string OborKomb { get; set; }

        public override string ToString()
        {
            return $"{OsCislo}, {Jmeno}, {Prijmeni}, {UserName}, {Rocnik}, {OborKomb}";
        }

    }

    public class ReadonlyDB
    {
        public static Student[] Students = new Student[]{
        new Student() {OsCislo="R200438", Jmeno="Martin", Prijmeni="BRABLAŤÁK", UserName="brabma04", Rocnik=2,OborKomb="IT"},
new Student() {OsCislo="R20148", Jmeno="Klára", Prijmeni="BRĂZDILOVĂ", UserName="brazkl01", Rocnik=2,OborKomb="INF-PVS"},
new Student() {OsCislo="R20649", Jmeno="Jiří­", Prijmeni="DIVIL", UserName="diviji00", Rocnik=2,OborKomb="IT"},
new Student() {OsCislo="R20152", Jmeno="Matěj", Prijmeni="DOSTÁL", UserName="dostma15", Rocnik=2,OborKomb="INF-PVS"},
new Student() {OsCislo="R20162", Jmeno="Matyáš", Prijmeni="HROCH", UserName="hrocma02", Rocnik=2,OborKomb="INF-PVS"},
new Student() {OsCislo="R20163", Jmeno="Matyáš", Prijmeni="HROCH", UserName="hrocma03", Rocnik=4,OborKomb="IT"},
new Student() {OsCislo="R20166", Jmeno="Miroslav", Prijmeni="JUREK", UserName="juremi02", Rocnik=2,OborKomb="INF-PVS"},
new Student() {OsCislo="R20658", Jmeno="Daniel", Prijmeni="KLEMENT", UserName="klemda00", Rocnik=2,OborKomb="IT"},
new Student() {OsCislo="R20171", Jmeno="Andrej", Prijmeni="KOLÁNEK", UserName="korian03", Rocnik=2,OborKomb="INF-PVS"},
new Student() {OsCislo="R20178", Jmeno="Filip", Prijmeni="MARTINÁK", UserName="martfi01", Rocnik=2,OborKomb="IT"},
new Student() {OsCislo="R20177", Jmeno="Filip", Prijmeni="MARTINÁK", UserName="martfi00", Rocnik=2,OborKomb="INF-PVS"},
new Student() {OsCislo="R20664", Jmeno="Petr", Prijmeni="MICHÁLEK", UserName="michpe05", Rocnik=2,OborKomb="IT"},
new Student() {OsCislo="R20666", Jmeno="Ondřej", Prijmeni="NEČESAL", UserName="neceon00", Rocnik=2,OborKomb="IT"},
new Student() {OsCislo="R20184", Jmeno="Veronika", Prijmeni="PAVLÁKOVÁ", UserName="pavlve11", Rocnik=2,OborKomb="INF-PVS"},
new Student() {OsCislo="R20673", Jmeno="Jakub", Prijmeni="PERNÍČEK", UserName="pernja02", Rocnik=2,OborKomb="IT"},
new Student() {OsCislo="R19761", Jmeno="Martin", Prijmeni="SKULAVÍK", UserName="skulma01", Rocnik=3,OborKomb="APLINF"},
new Student() {OsCislo="R20197", Jmeno="Petr", Prijmeni="PÍRKA", UserName="spirpe00", Rocnik=2,OborKomb="INF-PVS"},
new Student() {OsCislo="R20116", Jmeno="Natálie", Prijmeni="TRHLÁKOVÁ", UserName="trhlna00", Rocnik=2,OborKomb="INF-PVS"},
new Student() {OsCislo="R20201", Jmeno="Jan", Prijmeni="VYCHODIL", UserName="vychja02", Rocnik=2,OborKomb="INF-PVS"}
        };
    }
}