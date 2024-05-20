using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Movement/Follow Target")]
[RequireComponent(typeof(Rigidbody2D))]
public class FollowTarget : Physics2DObject
{
    // この変数は、オブジェクトが移動しようとする対象を指定します。
    public Transform target;

    [Header("Movement")]
    // 対象に向かって移動する際の速度を制御します。
    public float speed = 1f;

    // オブジェクトがターゲットを追跡する際にターゲットを向くかどうかを制御します。
    public bool lookAtTarget = false;

    // ターゲットに向ける方向を制御します。
    public Enums.Directions useSide = Enums.Directions.Up;

    // FixedUpdate は物理演算を実行する際に毎フレーム呼び出されます。
    void FixedUpdate()
    {
        // ターゲットが割り当てられていないか、何らかの理由で破壊された場合には何もしないようにします。
        if (target == null)
            return;

        // ターゲットの位置を動的に更新する
        Vector2 targetPosition = target.position;

        // lookAtTarget が true の場合には、オブジェクトがターゲットを向くように設定します。
        if (lookAtTarget)
        {
            Utils.SetAxisTowards(useSide, transform, targetPosition - (Vector2)transform.position);
        }

        // オブジェクトを対象に向かって移動させます。
        rigidbody2D.MovePosition(Vector2.Lerp(transform.position, targetPosition, Time.fixedDeltaTime * speed));
    }
}
