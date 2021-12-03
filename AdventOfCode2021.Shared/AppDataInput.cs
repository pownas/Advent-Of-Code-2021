﻿namespace AdventOfCode2021.Shared;

public class AppDataInput
{
    string folderDataPath = @"..\..\..\..\AdventOfCode2021.Shared\inputData\";

    /// <summary>
    /// Read data from: "../AdventOfCode2021.Shared/inputData/{dataInputFile}"
    /// </summary>
    /// <param name="dataInputFile"></param>
    /// <returns></returns>
    public List<string> ReadData(string dataInputFile)
    {
        string inputDataPath = folderDataPath + dataInputFile;
        List<string> returnString = new();
        using (StreamReader reader = File.OpenText(inputDataPath))
        {
            string? line = "";
            while ((line = reader.ReadLine()) is not null)
            {
                returnString.Add(line);
            }
        }
        return returnString;
    }

    public List<Dictionary<string, string>> ReadKeyValue(string dataInputFile, string separator1, string separator2)
    {
        StreamReader reader = File.OpenText(folderDataPath + dataInputFile);
        Dictionary<string, string> dictionary = new();
        List<Dictionary<string, string>> dictionaryList = new();
        string? row;
        while ((row = reader.ReadLine()) is not null)
        {
            if (row is "")
            {
                dictionaryList.Add(dictionary);
                dictionary = new Dictionary<string, string>();
            }
            else
            {
                string[] splitted = row.Split(separator1).ToArray();
                foreach (string s in splitted)
                {
                    string[] ss = s.Split(separator2).ToArray();
                    dictionary[ss[0]] = ss[1];
                }
            }
        }
        if (dictionary.Count > 0)
            dictionaryList.Add(dictionary);
        return dictionaryList;
    }
}
