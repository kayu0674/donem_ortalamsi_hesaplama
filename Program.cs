// See https://aka.ms/new-console-template for more information

Console.WriteLine("inkıkap vize notunu gir");
float inkv = float.Parse(Console.ReadLine());
Console.WriteLine("inkıkap final notunu gir");
float inkf = float.Parse(Console.ReadLine());

Console.WriteLine("turkdili vize notunu gir");
float trv = float.Parse(Console.ReadLine());
Console.WriteLine("turkdili final notunu gir");
float trf = float.Parse(Console.ReadLine());

Console.WriteLine("ingilizce vize notunu gir");
float ingv = float.Parse(Console.ReadLine());
Console.WriteLine("ingilizce final notunu gir");
float ingf = float.Parse(Console.ReadLine());

Console.WriteLine("siber guvenlik vize notunu gir");
float sbrv = float.Parse(Console.ReadLine());
Console.WriteLine("siber guvenlik final notunu gir");
float sbrf = float.Parse(Console.ReadLine());

Console.WriteLine("yapayzeka vize notunu gir");
float yzv = float.Parse(Console.ReadLine());
Console.WriteLine("yapayzeka final notunu gir");
float yzf = float.Parse(Console.ReadLine());
Console.WriteLine("yapayzeka quiz ortalamanı gir");
float yzq = float.Parse(Console.ReadLine());

Console.WriteLine("bil donanımı vize notunu gir");
float donv = float.Parse(Console.ReadLine());
Console.WriteLine("bil donanımı final notunu gir");
float donf = float.Parse(Console.ReadLine());
Console.WriteLine("bil donanımı 1.quiz notunu gir");
float donq1 = float.Parse(Console.ReadLine());
Console.WriteLine("bil donanımı 2.quiz notunu gir");
float donq2 = float.Parse(Console.ReadLine());
Console.WriteLine("bil donanımı 3.quiz notunu gir");
float donq3 = float.Parse(Console.ReadLine());

Console.WriteLine("matematik vize notunu gir");
float matv = float.Parse(Console.ReadLine());
Console.WriteLine("matematik final notunu gir");
float matf = float.Parse(Console.ReadLine());

Console.WriteLine("veritabanı vize notunu gir");
float veriv = float.Parse(Console.ReadLine());
Console.WriteLine("veritabanı final notunu gir");
float verif = float.Parse(Console.ReadLine());
Console.WriteLine("veritabanı quiz notunu gir");
float veriq = float.Parse(Console.ReadLine());

Console.WriteLine("programlama vize notunu gir");
float progv = float.Parse(Console.ReadLine());
Console.WriteLine("programlama final notunu gir");
float progf = float.Parse(Console.ReadLine());

double inko = inkv * 0.4 + inkf * 0.6;
double tro = trv * 0.4 + trf * 0.6;
double ingo = ingv * 0.4 + ingf * 0.6;
double sbro = sbrv * 0.4 + sbrf * 0.6;
double yzo = yzv * 0.35 + yzf * 0.5 + yzq * 0.15;
double dono = donv * 0.3 + donf * 0.4 + ((donq1 + donq2 + donq3) / 3) * 0.3;
double mato = matv * 0.4 + matf * 0.6;
double verio = veriv * 0.35 + verif * 0.5 + veriq * 0.15;
double progo = progv * 0.4 + progf * 0.6;

