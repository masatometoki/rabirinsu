using UnityEngine;

public class MoveRepeatedly : MonoBehaviour
{
	[SerializeField]
	[Tooltip("X軸方向に移動する振幅(0にすると移動しない)")]
	private float amplitudeX = 4.0f;

	[SerializeField]
	[Tooltip("Y軸方向に移動する振幅(0にすると移動しない)")]
	private float amplitudeY = 4.0f;

	[SerializeField]
	[Tooltip("Z軸方向に移動する振幅(0にすると移動しない)")]
	private float amplitudeZ = 4.0f;

	[SerializeField]
	[Tooltip("振幅する速さ")]
	private float amplitudeSpeed = 2.0f;

	/// <summary>
	/// ゲーム開始時の場所
	/// </summary>
	private Vector3 startPosition;

	// Start is called before the first frame update
	void Start()
	{
		// ゲーム開始時の位置
		startPosition = this.transform.position;

	}

	private void FixedUpdate()
	{
		// 移動させる
		// Mathf.Sin()にTime.timeを入れることで、-1から+1の間の値を取得できる。それにamplitudeSpeedをかけることで振幅の幅を作れる。
		// そして、startPositionを足すことで、スタート位置から左右に動くようになる。
		transform.position = new Vector3((Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeX + startPosition.x), (Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeY + startPosition.y), (Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeZ + startPosition.z));
	}
}
