using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropSpawner : MonoBehaviour
{
  [SerializeField] GameObject[] items;
  [SerializeField] float minSpawnSpeed;
  [SerializeField] float maxSpawnSpeed;

  bool spawning = true;

  // Start is called before the first frame update
  IEnumerator Start()
  {
      while (spawning)
      {
          yield return new WaitForSeconds(Random.Range(minSpawnSpeed, maxSpawnSpeed));
          SpawnItem();
      }
  }

  private void SpawnItem()
  {
      var itemIndex = Random.Range(0, items.Length);
      Spawn(items[itemIndex]);
  }

  private void StopSpawningItem()
  {
      spawning = false;
  }

  private void Spawn(GameObject myItem)
  {
      GameObject newItem = Instantiate(myItem, transform.position, Quaternion.identity) as GameObject;
      newItem.transform.parent = transform;
  }
}
