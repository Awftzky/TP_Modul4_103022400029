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