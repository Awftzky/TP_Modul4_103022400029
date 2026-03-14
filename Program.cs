// See https://aka.ms/new-console-template for more information
class kodepos {
    public static int getKodePos(string kelurahan){

        Dictionary<string, int> tabelKodePos = new Dictionary<string, int>() {
            {"Batununggal", 40266}, {"Kujangsari", 40287}, {"Mengger", 40267},
            {"Wates", 40256}, {"Cijaura", 40287}, {"Jatisari", 40286},
            {"Margasari", 40286}, {"Sekejati", 40286}, {"Kebonwaru", 40272},
            {"Maleer", 40274}
        };

        return tabelKodePos.ContainsKey(kelurahan) ? tabelKodePos[kelurahan] : 0;
    }
}

class DoorMachine {
    enum State { Terkunci, Terbuka }
    private State currentState = State.Terkunci;

    public void PerubahanState(string command) {
        if (command == "BukaPintu" && currentState == State.Terkunci) {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        } else if (command == "KunciPintu" && currentState == State.Terbuka) {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}