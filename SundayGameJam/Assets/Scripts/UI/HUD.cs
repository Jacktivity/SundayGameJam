using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    private float health;
    private float ammo;

    public Slider healthSlider;
    public Slider overheatSlider;

    bool heating = false;
    public int regenTime = 5;
    public int overheatIncrease = 1;
    int overheat;

    // Start is called before the first frame update
    void Start() {
        health = getHealth();
        ammo = getAmmo();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.W))
        {
            TakeDamage(1);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            LoseAmmo(5);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Fire();
        }
    }

    public void TakeDamage(float damage) {
        health = health - damage;
        healthSlider.value = health;
    }

    private void LoseAmmo(float value) {
        ammo = ammo - value;
        overheatSlider.value = ammo;
    }

    public void Fire() {
        StopCoroutine("AmmoRegen");
        LoseAmmo(5);

        StartCoroutine("AmmoRegen");
    }

    IEnumerator AmmoRegen() {
        yield return new WaitForSeconds(1);
        while (ammo < overheatSlider.maxValue) {
            yield return new WaitForSeconds(1);
            ammo += overheatIncrease;
            overheatSlider.value = ammo;
        }
    }

    float getHealth() {
        return 100;
    }

    float getAmmo() {
        return 100;
    }
}
