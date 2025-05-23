using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Views.Main_Menu
{
    public abstract class MainMenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Header("Object References")]
        [SerializeField] protected UIView mainMenuView;
        
        public virtual void OnPointerEnter(PointerEventData eventData)
        {
            
        }

        public virtual void OnPointerExit(PointerEventData eventData)
        {
            
        }
    }
}
