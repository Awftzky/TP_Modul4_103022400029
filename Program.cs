// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

Console.WriteLine("-- Tugas TABLE-DRIVEN (KODE POS) --");
string kelurahan = "Batununggal";
Console.WriteLine($"Kelurahan: {kelurahan}, Kode Pos: {KodePos.getKodePos(kelurahan)}");

Console.WriteLine("\n-- TUGAS STATE-BASED (DOOR MACHINE) -");
DoorMachine pintu = new DoorMachine();
pintu.PerubahanState("BukaPintu");  
pintu.PerubahanState("KunciPintu"); 