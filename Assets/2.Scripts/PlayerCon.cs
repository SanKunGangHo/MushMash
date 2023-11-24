using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    public float moveSpeed; //움직이는 속도 하이라키 창에서 변경가능

    public void FixedUpdate()
    { //그냥 Update로 할 경우 cpu의 성능에 따라서 더 빨라질 수 있기 때문에, 일정한 속도를 유지하는 FixedUpdate를 사용

        this.transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed * Time.deltaTime);

        //this = 이 스크립트가 들어있는 오브젝트

        //transform = 하이라키 창을 보면 rect transform이라고 좌표값 설정하는 거 있음.

        //Translate(x, y, z) = transform의 xyz의 일정좌표로 이동하는 스크립트.

        //Input = 컴퓨터의 입력값. 여기선 키보드의 wasd나 상하좌우 화살표 같은 키보드 입력값을 뜻함.

        //GetAxis("수평Horizontal 혹은 수직Vertical") = 축을 가져오는 글씨. 0이었다가 a나 d, 혹은 좌 우 화살표를 누르면 좌는 -1, 우는 +1값이 됨. 기본값은 0.

        //moveSpeed = 변수. 플레이어의 하이라키창에 이 스크립트를 끌어넣거나, Add Components 버튼으로 "PlayerController"를 넣으면 public으로 설정되어있어 하이라키창에서 직접 숫자를 바꿀 수 있음. 이렇게 설정해두면, 다른 곳에서 같은 스크립트를 사용할 때, 각각의 오브젝트에 각각 다른 값을 넣을 수 있음.

        //Time.deltaTime

    }
}
