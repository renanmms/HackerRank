var ar = new int[]{1, 2, 3, 4, 5, 6};
var k = 5;

var pairs = 0;

for(int i = 0; i < ar.Length; i++) {
    for(int j = 0; j < ar.Length; j++){
        if(i < j && (ar[i] + ar[j]) % k == 0){
            pairs++;
        }
    }
}

Console.WriteLine(pairs);