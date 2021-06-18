using UnityEngine;

public class MoveRepeatedly : MonoBehaviour
{
	[SerializeField]
	[Tooltip("X�������Ɉړ�����U��(0�ɂ���ƈړ����Ȃ�)")]
	private float amplitudeX = 4.0f;

	[SerializeField]
	[Tooltip("Y�������Ɉړ�����U��(0�ɂ���ƈړ����Ȃ�)")]
	private float amplitudeY = 4.0f;

	[SerializeField]
	[Tooltip("Z�������Ɉړ�����U��(0�ɂ���ƈړ����Ȃ�)")]
	private float amplitudeZ = 4.0f;

	[SerializeField]
	[Tooltip("�U�����鑬��")]
	private float amplitudeSpeed = 2.0f;

	/// <summary>
	/// �Q�[���J�n���̏ꏊ
	/// </summary>
	private Vector3 startPosition;

	// Start is called before the first frame update
	void Start()
	{
		// �Q�[���J�n���̈ʒu
		startPosition = this.transform.position;

	}

	private void FixedUpdate()
	{
		// �ړ�������
		// Mathf.Sin()��Time.time�����邱�ƂŁA-1����+1�̊Ԃ̒l���擾�ł���B�����amplitudeSpeed�������邱�ƂŐU���̕�������B
		// �����āAstartPosition�𑫂����ƂŁA�X�^�[�g�ʒu���獶�E�ɓ����悤�ɂȂ�B
		transform.position = new Vector3((Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeX + startPosition.x), (Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeY + startPosition.y), (Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeZ + startPosition.z));
	}
}
