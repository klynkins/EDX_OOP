using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System Threading.Tasks;

namespeace ThirdModule
{
	class Customer : ILoyaltyCardHolder
	{
		private int totalPoints;

		public int TotalPoints
		{
			get { return totalPoints; }
		} 
		
		public int AddPoints(decimal transactionValue)
		{
			int points = Decimal.ToInt32(transactionValue);
			totalPoints += points;
			return totalPoints;
		}
		public void ResetPoints()
		{
			totalPoints = 0;
		}
		// Other members of the customer class.
	}
}