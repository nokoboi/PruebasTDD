using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

public class ScriptTestMode1
{
    private GameObject Sphere;
    private GameObject Cube;

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene("SampleScene");
        Debug.Log("Cargando la escena");
    }
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator EsferaSobreElCubo()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return new WaitForSeconds(5);
        Sphere = GameObject.Find("Sphere");
        Cube = GameObject.Find("Cube");

        // Obtén las escalas de los objetos Sphere y Cube
        Vector3 sphereScale = Sphere.transform.localScale;
        Vector3 cubeScale = Cube.transform.localScale;

        // Usa Assert para comparar las escalas
        Assert.That(sphereScale.y > cubeScale.y, "La escala de la esfera no es mayor que la escala del cubo");
    }

    [TearDown]
    public void TearDown()
    {
        EditorSceneManager.UnloadSceneAsync("SampleScene");
    }
}
