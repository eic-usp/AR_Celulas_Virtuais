using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class ContentManager : MonoBehaviour
{
    public static ContentManager Instance { get; private set; }
    
    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI organelleNameText;
    [SerializeField] private TextMeshProUGUI organelleDescriptionText;
    [SerializeField] private GameObject audioButton;
    [SerializeField] private Image audioButtonImage;
    [SerializeField] private Sprite audioOnSprite;
    [SerializeField] private Sprite audioOffSprite;
    
    private AudioSource _audioSource;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        audioButton.SetActive(false);
    }
    
    public void SetContent(OrganelleData organelleData)
    {
        if (panel.activeSelf) return;
        
        panel.SetActive(true);
        audioButton.SetActive(true);
        
        organelleNameText.text = organelleData.Name;
        organelleDescriptionText.text = organelleData.Description;
        _audioSource.clip = organelleData.Audio;
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
        audioButton.SetActive(false);
        _audioSource.Stop();
    }

    public void ToggleAudio()
    {
        if (_audioSource.isPlaying)
        {
            audioButtonImage.sprite = audioOffSprite;
            _audioSource.Stop();
            return;
        }
        
        audioButtonImage.sprite = audioOnSprite;
        _audioSource.Play();
    }
    
    private void Update()
    {
        if (_audioSource.isPlaying) return;
        audioButtonImage.sprite = audioOffSprite;
    }
}
