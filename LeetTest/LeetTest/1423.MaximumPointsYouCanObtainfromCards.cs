int[] arr = { 1, 2, 3, 4, 5, 6, 1 };
//int[] arr = { 96, 90, 41, 82, 39, 74, 64, 50, 30 };
int k = 3;

MaxScore(arr, k);

int MaxScore(int[] cardPoints, int k)
{
	int n = cardPoints.Length, sum = 0;

	for (int i = 0; i < k; i++) sum += cardPoints[i]; 

	int max = sum;
	for (int i = 0; i < k; i++)
	{
		var t1 = cardPoints[k - i - 1];
		var t2 = cardPoints[n - i - 1];

		sum = sum - cardPoints[k - i - 1] + cardPoints[n - i - 1];
		max = Math.Max(max, sum);
	}
	return max;




	//int l = cardPoints.Length, sum = 0;

	//for (int i = 0; i < k; i++) sum += cardPoints[i];

	//if (l == k) return sum;

	//int max = sum;
	//for (int i = 0; i < k; i++)
	//{
	//	var t1 = cardPoints[k - i - 1];
	//	var t2 = cardPoints[l - i - 1];

	//	sum = sum - t1 + t2;
	//	max = Math.Max(max, sum);
	//}
	
	//return sum;
}



//int MaxScore(int[] cardPoints, int k)
//{
//	int maxSum = 0;

//	if (cardPoints.Length == k)
//	{
//		foreach (var p in cardPoints) maxSum += p;
//		return maxSum;
//	}

//	int[] rigthSum = new int[k+1];
//	int[] leftSum = new int[k+1];

//	for (int i = 0; i < k; i++) {
//		if (i == 0)
//			rigthSum[i+1] = cardPoints[i];
//		else 
//			rigthSum[i+1] = rigthSum[i] + cardPoints[i];
//	}

//	for (int i = 0; i<k; i++)
//	{
//		if (i == 0)
//			leftSum[i+1] = cardPoints[cardPoints.Length-1];
//		else
//			leftSum[i+1] = leftSum[i] + cardPoints[cardPoints.Length - 1 - i];
//	}

//	for(int i = 0; i<=k; i++)
//	{
//		var firstSum = rigthSum[i];
//		var backSum = leftSum[k-i];
//		maxSum = Math.Max(maxSum, firstSum + backSum);
//	}

//	return maxSum;
//}