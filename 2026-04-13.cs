public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int distancia = 0;
        int posicaoAlvo = 0;
        int posicaoInicial = 0;
        int possiveisAlvos = 0;
        var menorDistancia = 10001;

        for(int i=0; i < nums.Length; i++){
                
            if(nums[i] == target){
                distancia = i - start;
                if(distancia < 0 ){
                    distancia = distancia * - 1;
                }
                if(distancia < menorDistancia){
                menorDistancia = distancia;
                    
            } 
            }
            
        }    
        return menorDistancia;
    }
}