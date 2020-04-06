public class JsonHelper
{
	public static T[] GetArray<T> (string json)
	{
		string newJson = "{\"data\":" + json + "}";
		Wrapper<T> w = UnityEngine.JsonUtility.FromJson<Wrapper<T>> (newJson);
		return w.data;
	}

	[System.Serializable] class Wrapper<T>
	{
		public T[] data;
	}
}
