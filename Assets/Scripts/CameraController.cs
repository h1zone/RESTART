using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Класс движения камеры по сцене")]

    [Tooltip("Крайние точки квадарата, куда может доходить камера")]
    public float clampXmin, clampXmax, clampYmin, clampYmax;

    // Хранит стартовую позицию свайпа
    private Vector2 startPos;

    // переменная используется для перевода координат курсора в мировые координаты, чтобы понять куда двигается камера
    private Camera cam;

    // Движимый объект = камера, по этому берем компонент камеры на нем
    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Если был тап по экрану или нажата левая кнопка мушки (GetMouseButtonDown выполняется только один кадр)
    //   то переводим координаты тапа с экрана в мировые координаты
    // иначе если зажата ли кнопка?
    //   то от текущей позиции курсора вычитаем стартовую позицию (по двум осям)
    //   изменяем позицию камеры (от текущей позиции камеры отнимаем позицию смещения)
    //   Mathf.Clamp - ограничиваем передвижение камеры в заданных пределах
    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            startPos = cam.ScreenToWorldPoint(Input.mousePosition);
        }
        
        else if (Input.GetMouseButton(0))
        {
            float posX = cam.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
            float posY = cam.ScreenToWorldPoint(Input.mousePosition).y - startPos.y;
            
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x - posX, clampXmin, clampXmax), 
                Mathf.Clamp(transform.position.y - posY, clampYmin, clampYmax), 
                transform.position.z);
        }
    }
}
