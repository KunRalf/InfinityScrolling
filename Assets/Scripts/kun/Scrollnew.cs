using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;
using Task = System.Threading.Tasks.Task;

namespace DefaultNamespace.kun
{
    public class Scrollnew : MonoBehaviour
    {
        [SerializeField] private ScrollRect _scroll;
        private bool positiveDrag => _scroll.velocity.x > 0;

        [SerializeField] private HorizontalLayoutGroup _horizontalLayout;
        [SerializeField] private ContentSizeFitter _contentSizeFitter;


        public async void Init()
        {
            _horizontalLayout.enabled = true;
            _contentSizeFitter.enabled = true;
            await Task.Delay(10);
            _horizontalLayout.enabled = false;
            _contentSizeFitter.enabled = false;
            
        }

    }
}