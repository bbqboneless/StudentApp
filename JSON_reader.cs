using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Proyecto21
{
	class JSON_reader
	{
		private static JSON_reader _instance = null;

		private static object _handle = new object();
		//guardar la info del JSON para usarla en la App
		public UserList user { get; set; }
		public ScoreList score { get; set; }
		public SubjectList subject { get; set; }

		protected JSON_reader()
		{
			user = JsonSerializer.Deserialize<UserList>(Read(@"..\..\..\user.json"));
			score = JsonSerializer.Deserialize<ScoreList>(Read(@"..\..\..\score.json"));
			subject = JsonSerializer.Deserialize<SubjectList>(Read(@"..\..\..\subject.json"));
		}

		public static JSON_reader Instance
		{
			get
			{
				lock (_handle)
				{
					if (_instance == null)
					{
						_instance = new JSON_reader();
					}
				}

				return _instance;
			}
		}
		//para leer el archivo
		private static string Read(string file)
		{
			using var s = File.OpenRead(file);
			using var r = new StreamReader(s);
			return r.ReadToEnd();
		}
	}
	//para agarrar los datos creamos clases a partir de los JSONs que creamos
	public class User
	{
		public string name { get; set; }
		public string major { get; set; }
		public int birth_date { get; set; }
		public string city { get; set; }
		public string username { get; set; }
		public string password { get; set; }
		public string type { get; set; }
	}

	public class Score
	{
		public int subject_id { get; set; }
		public float score { get; set; }
		public string student { get; set; }
	}

	public class Subject
	{
		public int subject_id { get; set; }
		public string name { get; set; }
		public string teacher { get; set; }
	}
	//para agarrar toda la info individual junta de cada JSON
	public class UserList
	{
		public List<User> Data { get; set; }
	}

	public class ScoreList
	{
		public List<Score> Data { get; set; }
	}

	public class SubjectList
	{
		public List<Subject> Data { get; set; }
	}
}

