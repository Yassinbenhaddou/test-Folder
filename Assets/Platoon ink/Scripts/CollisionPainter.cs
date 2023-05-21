using UnityEngine;

public class CollisionPainter : MonoBehaviour{
    public Color paintColor;
    
    public float radius = 1;
    public float strength = 1;
    public float hardness = 1;

    private void OnCollisionStay(Collision other) {
        //print("CollisionPainter: OnCollisionStay");
        Paintable p = other.collider.GetComponent<Paintable>();
        if(p != null){
            Vector3 pos = other.contacts[0].point;
            PaintManager.instance.paint(p, pos, radius, hardness, strength, paintColor);
            print("CollisionPainter: OnCollisionStay: Painted");
        }else
        {
            print("CollisionPainter: OnCollisionStay: Paintable is null");
        }
    }
}
