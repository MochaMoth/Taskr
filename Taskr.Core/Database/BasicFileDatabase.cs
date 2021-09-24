using Taskr.Core.Utilities;
using Newtonsoft.Json;
using System.IO;
using System;
using Taskr.Core.DateTimeWrappers;
using System.Collections.Generic;

namespace Taskr.Core.Database
{
	public class BasicFileDatabase : IDatabase
	{
		private readonly string _saveDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/{Environment.UserName}";
		private readonly string _fileType = "day";

		public void Initialize()
		{
			//
		}

		public void AddRecord<T>(T record) where T : IRecord, new()
		{
			ObjectUtilities.EnsureObjectIsSerializable<T>();

			RecordTracker recordTracker = new RecordTracker(0, record);

			CreateFileAndDirectoryByTime(DateTimeWrapper.Now);

			string currentRecords = File.ReadAllText(GetFileStringByDate(DateTimeWrapper.Now));
			List<RecordTracker> records = new List<RecordTracker>();
			if (!string.IsNullOrEmpty(currentRecords))
				records = JsonConvert.DeserializeObject<List<RecordTracker>>(currentRecords);

			records.Add(recordTracker);

			string jsonRecords = JsonConvert.SerializeObject(records, Formatting.Indented);
			string filePath = GetFileStringByDate(DateTimeWrapper.Now);

			File.WriteAllText(filePath, jsonRecords);
		}

		void CreateFileAndDirectoryByTime(DateTime dateTime)
		{
			string directory = GetDirectoryStringByDate(dateTime);
			string file = GetFileStringByDate(dateTime);

			if (!Directory.Exists(directory))
				_ = Directory.CreateDirectory(directory);

			if (!File.Exists(file))
				_ = File.Create(file);
		}

		string GetFileStringByDate(DateTime dateTime)
		{
			string directory = GetDirectoryStringByDate(dateTime);
			return $"{directory}/{dateTime.Day}.{_fileType}";
		}

		string GetDirectoryStringByDate(DateTime dateTime)
		{
			return $"{_saveDirectory}/{dateTime.Year}/{dateTime.Month}";
		}
	}
}
