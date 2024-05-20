using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Movement/Follow Target")]
[RequireComponent(typeof(Rigidbody2D))]
public class FollowTarget : Physics2DObject
{
    // ���̕ϐ��́A�I�u�W�F�N�g���ړ����悤�Ƃ���Ώۂ��w�肵�܂��B
    public Transform target;

    [Header("Movement")]
    // �ΏۂɌ������Ĉړ�����ۂ̑��x�𐧌䂵�܂��B
    public float speed = 1f;

    // �I�u�W�F�N�g���^�[�Q�b�g��ǐՂ���ۂɃ^�[�Q�b�g���������ǂ����𐧌䂵�܂��B
    public bool lookAtTarget = false;

    // �^�[�Q�b�g�Ɍ���������𐧌䂵�܂��B
    public Enums.Directions useSide = Enums.Directions.Up;

    // FixedUpdate �͕������Z�����s����ۂɖ��t���[���Ăяo����܂��B
    void FixedUpdate()
    {
        // �^�[�Q�b�g�����蓖�Ă��Ă��Ȃ����A���炩�̗��R�Ŕj�󂳂ꂽ�ꍇ�ɂ͉������Ȃ��悤�ɂ��܂��B
        if (target == null)
            return;

        // �^�[�Q�b�g�̈ʒu�𓮓I�ɍX�V����
        Vector2 targetPosition = target.position;

        // lookAtTarget �� true �̏ꍇ�ɂ́A�I�u�W�F�N�g���^�[�Q�b�g�������悤�ɐݒ肵�܂��B
        if (lookAtTarget)
        {
            Utils.SetAxisTowards(useSide, transform, targetPosition - (Vector2)transform.position);
        }

        // �I�u�W�F�N�g��ΏۂɌ������Ĉړ������܂��B
        rigidbody2D.MovePosition(Vector2.Lerp(transform.position, targetPosition, Time.fixedDeltaTime * speed));
    }
}
