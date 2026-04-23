public class Solution {
    public int MaxDistance(int[] colors) {
        int distanciaMaxima = 0;
        //int primeiraCor = 0;
        for(int i =0; i < colors.Length; i++){
            int primeiraCor = colors[i];
            for(int j = i + 1; j < colors.Length; j++){
                int segundaCor = colors[j];
                if(primeiraCor != segundaCor){
                    int distancia = Math.Abs(i - j);
                    if(distancia > distanciaMaxima){
                        distanciaMaxima = distancia;
                    }
                }   
            }
        }
        return distanciaMaxima;
    }
}

//about 20 minutes, without using AI help 