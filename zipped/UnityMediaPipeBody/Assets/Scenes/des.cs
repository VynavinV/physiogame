using UnityEngine;
using UnityEngine.Video;

public class des : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    [SerializeField] private GameObject additionalObject; // Reference to the additional GameObject

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += OnVideoEnd;
        }

    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        // Destroy the current GameObject
        Destroy(gameObject);

        // Destroy the additional GameObject if it is assigned
        if (additionalObject != null)
        {
            Destroy(additionalObject);
        }
    }

    private void OnDestroy()
    {
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached -= OnVideoEnd;
        }
    }
}
