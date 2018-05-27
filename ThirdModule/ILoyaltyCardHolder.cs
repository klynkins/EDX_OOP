namespace ThirdModule
{
	interface ILoyaltyCardHolder
	{
		int TotalPoint { get; }
		int AddPoints(decimal transactionValue);
		void ResetPoints();
	}
}