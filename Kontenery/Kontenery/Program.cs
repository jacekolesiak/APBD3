using Kontenery;

Kontener kontener1 = new CoolingKontener(100,100,100,100,"banana",10,5);
Kontener kontener2 = new GasKontener(100,100,100,100,1000);
Kontener kontener3 = new LiquidKontener(100,100,100,100,"regular");

kontener1.LoadCargo(50);
kontener2.LoadCargo(50);
kontener3.LoadCargo(50);

KontenerShip kontenerShip = new KontenerShip(100,100,10000);
kontenerShip.Konteners.Add(kontener1);

List<Kontener> list = new List<Kontener>();
list.Add(kontener2);
list.Add(kontener3);

kontenerShip.AddConteiners(list);

kontenerShip.RemoveKontener("KON-C-0");
kontener1.ClearLoad();

kontenerShip.ReplaceKontener(kontener1,"KON-G-1");

KontenerShip kontenerShip2 = new KontenerShip(100,100,10000);

kontenerShip.MoveKontener(kontenerShip2,"KON-L-2");

Console.WriteLine(kontener1);
Console.WriteLine(kontenerShip);