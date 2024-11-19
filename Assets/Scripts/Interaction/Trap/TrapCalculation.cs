using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Traps job are just deal damage to player, so I just write a specific script for this.
I'm just too lazy to copy paste the codes for dealing damage,
Since there may have different types of traps in the future dev. like ground spikes, falling spikes or lava etc.,
but this time we just have one type of trap which is just ground spikes.
We make this class to be abstracted since we don't need to activate this class in our scene.
Its job is just share its variables and functions to other classes that needs it.
*/

public abstract class TrapCalculation : MonoBehaviour, IHit
{
    public void PlayerHit(int damage)   //only public method can be applied for interface that handles itself
    {

        PlayerStats.Instance.health -= damage;
        Debug.Log("Health: " + PlayerStats.Instance.health);
        if (PlayerStats.Instance.health <= 0)
        {
            Debug.Log("You died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
