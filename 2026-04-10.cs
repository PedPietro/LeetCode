public class Solution {
    public int MinimumDistance(int[] nums) {
    //good if nums[i] == nums[j] == nums[k]
    int distanciaMinima = int.MaxValue;
    if(nums.Length < 3){
        distanciaMinima = -1;
        return distanciaMinima;
    }
    else{
        for(int i =0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[j] == nums[i]){
                    for(int k = j + 1; k < nums.Length; k++){
                        if(nums[i] == nums[j] && nums[j] == nums[k]){
                            distanciaMinima = Math.Min(distanciaMinima, (Math.Abs(i-j) + Math.Abs(j-k) + Math.Abs(k-i)));
                        }
                    } 
                }
            }   
        }
        if(distanciaMinima == int.MaxValue || distanciaMinima < 2){
            distanciaMinima = -1;
        }
        return distanciaMinima;
    }
     
    }
}