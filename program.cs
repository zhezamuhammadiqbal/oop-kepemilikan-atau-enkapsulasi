using v24;

Rumus rumus = new Rumus ();
Console.WriteLine(rumus.tampil());
Console.Write("inputkan panjang : ");
int p = Convert.ToInt16(Console.ReadLine());
Console.Write("inputkan lebar : ");
int l = Convert.ToInt16(Console.ReadLine());
Console.Write("inputkan tinggi : ");
int t = Convert.ToInt16(Console.ReadLine());
rumus.kali(p,l);
Console.Write("Volume Balok Adalah : ");
Console.WriteLine(rumus.balok(t));
