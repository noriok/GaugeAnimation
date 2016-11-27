using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField]
    private Image _gauge;

    private GaugeAnimation _gaugeAnimation;

	void Start()
	{
	    _gaugeAnimation = new GaugeAnimation(_gauge);
    }

    void OnGUI()
    {
        float p = 0;
        if (GUI.Button(new Rect(20, 20, 100, 50), "+10"))
        {
            p = 0.1f;
        }
        else if (GUI.Button(new Rect(20, 80, 100, 50), "+30"))
        {
            p = 0.3f;
        }
        else if (GUI.Button(new Rect(20, 140, 100, 50), "+50"))
        {
            p = 0.5f;
        }
        else if (GUI.Button(new Rect(20, 200, 100, 50), "+100"))
        {
            p = 1.0f;
        }
        else if (GUI.Button(new Rect(20, 260, 100, 50), "+120"))
        {
            p = 1.2f;
        }
        else if (GUI.Button(new Rect(20, 320, 100, 50), "+150"))
        {
            p = 1.5f;
        }

        if (p > 0)
        {
            _gaugeAnimation.Progress(p);
        }
    }

	void Update()
	{
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        float p = 1.2f;
	        _gaugeAnimation.Progress(p);
            _gaugeAnimation.Progress(1.2f);
	    }
	}
}
