using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBMng
{
    private const string SCORE_LEVEL = "score-level-";
    private const string ENABLE_LEVEL = "enable-level-";
    private const string MEDAL_LEVEL = "medal_level";

    public static void SaveLevel(int id, float score, int medal)
    {
        float scoreLevel = GetScoreLevel(id);
        if (scoreLevel < score)
        {
            PlayerPrefs.SetFloat(SCORE_LEVEL + id, score);
        }
        int medalLevel = GetMedalLevel(id);
        if (medalLevel < medal) 
        { 
            PlayerPrefs.SetInt(MEDAL_LEVEL + id, medal);
        }
        PlayerPrefs.SetInt(ENABLE_LEVEL + (id + 1), 1);
    }

    public static float GetScoreLevel(int id)
    {
        return PlayerPrefs.GetFloat(SCORE_LEVEL + id);
    }

    public static int GetEnableLevel(int id)
    {
        return PlayerPrefs.GetInt(ENABLE_LEVEL + id);
    }

    public static int GetMedalLevel(int id)
    {
        return PlayerPrefs.GetInt(MEDAL_LEVEL + id);
    }
}
