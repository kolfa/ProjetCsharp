// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bonjour !!");
Console.WriteLine("How are you ?");
void construirePyramid(int numbre){
    int nb, esp,i,j,k;
    Console.WriteLine("Entrez le nombre de lignes: ");
    nb = int.Parse(Console.ReadLine());
	esp = nb-1 ;
	for (i=0;i<nb;++i){
		for (j=0;j<(esp-i);++j){
			Console.Write (" ");
		}
		for (k=0;k<=(2*i);++k){
			Console.Write ("*");
		}
		Console.Write ("\n");
	}
}
construirePyramid(3);
