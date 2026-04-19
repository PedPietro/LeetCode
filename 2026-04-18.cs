public class Solution {
    public  int MirrorDistance(int n) {
        
        int reverso = 0;
        int caracteres = 0;
        int numero = n;

        if(n == 0 || n < 10){
            return n;
        }
        else{
            while(numero > 0){
                numero = numero / 10;
                caracteres += 1;
            }
            numero = n;
            for(int i=caracteres; i > 0; i--){
                    int resto = numero % 10;//25 -> 5;
                    numero = numero / 10;//25 = 2
                    reverso += resto * (int)Math.Pow(10, i - 1);// 5 * 10^1 = 50; 2 + 10^0 = 2 
                } 
                int resultado = Math.Abs(n - reverso);
                return resultado;
            } 
    }
}