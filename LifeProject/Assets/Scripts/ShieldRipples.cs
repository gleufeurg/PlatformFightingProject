using UnityEngine;
using UnityEngine.VFX;

public class ShieldRipples : MonoBehaviour
{
    public GameObject shieldRipples;
    VisualEffect shieldRipplesVFX;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Attack")
        {
            var ripples = Instantiate(shieldRipples, transform) as GameObject;
            shieldRipplesVFX = ripples.GetComponent<VisualEffect>();
            shieldRipplesVFX.SetVector3("SphereCenter", collision.contacts[0].point);

            Destroy(ripples, 2);
        }
    }
}
