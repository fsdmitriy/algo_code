var trips = new int[][] { new int[] { 10, 1, 6 }, new int[] { 7, 5, 6 }, new int[] { 6, 7, 8 }, };

var result = CarPooling(trips, 16);
var result1 = CarPoolingDict(trips, 16);

bool CarPoolingDict(int[][] trips, int capacity)
{
    var stops = new Dictionary<int, int>();
    foreach (var t in trips)
    {
        if (stops.TryGetValue(t[1], out int start))
            stops[t[1]] += t[0];
        else
            stops.Add(t[1], 0 + t[0]);

        if (stops.TryGetValue(t[2], out int end))
            stops[t[2]] -= t[0];
        else
            stops.Add(t[2], 0 - t[0]);
    }

    stops = stops.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);

    foreach (var s in stops)
    {
        if (capacity < 0) { return false; }
        capacity -= s.Value;
    }

    return capacity >= 0;
}


bool CarPooling(int[][] trips, int capacity)
{
    int[] stops = new int[1001];

    foreach (var t in trips)
    {
        stops[t[1]] += t[0];
        stops[t[2]] -= t[0];
    }

    for (int i = 0; capacity >= 0 && i < 1001; ++i)
        capacity -= stops[i];
    return capacity >= 0;
}