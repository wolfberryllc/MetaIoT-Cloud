using Firebase.Database;
using Firebase;
//using Firebase.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;



using System.Threading.Tasks;

public class UserScoreData
{
    public string username;
    public float A0;
    public float A1;
    public float A2;
    public float A3;
    public string time;

    public UserScoreData(string name, float a0, float a1, float a2, float a3, string time)
    {
        username = name;
        A0 = a0;
        A1 = a1;
        A2 = a2;
        A3 = a3;
        this.time = time;
    }
}
public class Script : MonoBehaviour
{

    DatabaseReference reference;
    public InputField Score;
    public Text showLoadedText;

    public GameObject scoreboard_UI;

    public GameObject contentListBoard;

    public ScoreUIIndex scoreUIIndexPrefab;

    List<UserScoreData> userScoreDatas = new List<UserScoreData>();

    // Start is called before the first frame update
    void Start()
    {
      // Screen.orientation = ScreenOrientation.LandscapeLeft;
        //FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://farmvillarestapi-default-rtdb.firebaseio.com/");
        // Get the root reference location of the database.
        reference = FirebaseDatabase.DefaultInstance.RootReference;
    }



    public void ShowLeaderBoard()
    {
        scoreboard_UI.SetActive(true);
        foreach (Transform child in contentListBoard.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        StartCoroutine(LoadScorelistCoroutine());
    }

    public async Task<DataSnapshot> LoadScorelist()
    {
        DataSnapshot dataSnapshot = await FirebaseDatabase.DefaultInstance.GetReference("Scorelist").GetValueAsync();
        if (dataSnapshot.Exists)
        {
            string json = dataSnapshot.GetRawJsonValue();
            Debug.Log(dataSnapshot.GetRawJsonValue());
            return dataSnapshot;
        }
        return null;
    }

    public IEnumerator LoadScorelistCoroutine()
    {
        var loadTask = LoadScorelist();
        yield return new WaitUntil(() => loadTask.IsCompleted);
        DataSnapshot dataSnapshot = loadTask.Result; //your data here
        if (dataSnapshot != null)
        {
            userScoreDatas.Clear();
            var chilList = dataSnapshot.Children.ToList();
            foreach (var item in chilList)
            {
                if (string.IsNullOrEmpty(item.Key))
                {
                    continue;
                }
                var child = dataSnapshot.Child(item.Key);
                float score0 = float.Parse(child.Child("0").Child("A0").GetRawJsonValue());
                float score1 = float.Parse(child.Child("1").Child("A1").GetRawJsonValue());
                float score2 = float.Parse(child.Child("2").Child("A2").GetRawJsonValue());
                float score3 = float.Parse(child.Child("3").Child("A3").GetRawJsonValue());
                string time = child.Child("4").Child("Time").GetRawJsonValue();
                //Debug.Log(score0);
                //Debug.Log(score1);
                //Debug.Log(score2);
                //Debug.Log(score3);

                //showLoadedText.text = "User: " +item.Key + " Score: " + score0.ToString();

                userScoreDatas.Add(new UserScoreData(item.Key, score0, score1, score2, score3, time));
            }

            if (userScoreDatas.Count > 0)
            {
                for (int i = userScoreDatas.Count - 1; i >= 0; i--)
                {
                    var user = userScoreDatas[i];
                    ScoreUIIndex scoreUIIndex = Instantiate(scoreUIIndexPrefab, contentListBoard.transform);
                    scoreUIIndex.NewScoreElement(user.A0, user.A1, user.A2, user.A3, user.time);
                }
            }

        }


    }

}
