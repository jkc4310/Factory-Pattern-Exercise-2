using System;
namespace FactoryPatternExercise2
{
	public interface IDataAccess
	{
		public void LoadData();

		public void SaveData();
	}
}

