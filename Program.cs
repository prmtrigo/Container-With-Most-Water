namespace Container_With_Most_Water;
class Program
{
    static void AreaMaxima(int[] altura){

        //definindo os termos
        int areaMaxima = 0;
        int esquerda = 0;
        int direita = altura.Length -1;

        while(direita > esquerda){
            //definindo o que é a largura (direita - esquerda)
            int largura = direita - esquerda;
            //definindo o que é a área máxima
            //altura * largura
            areaMaxima = Math.Max(areaMaxima, Math.Min(altura[esquerda], altura[direita]) * largura);
            if(altura[esquerda] <= altura[direita]){
                esquerda++;
            }
            else{
                direita--;
            }

        }

        //printando o final 
        Console.WriteLine("A área máxima é: " + areaMaxima);
    }

    static void Main(string[] args)
    {

        int[] altura = {1,8,6,2,5,4,8,3,7};

        AreaMaxima(altura);
    }
}
