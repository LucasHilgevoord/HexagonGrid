using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGrid : MonoBehaviour {

    private int width = 30;
    private int height = 18;

    public HexCell cellPrefab;

    HexCell[] cells;
    public HexMesh hexMesh;

    void Start() {
        StartCoroutine("SpawnGrid");
    }

    IEnumerator SpawnGrid() {
        cells = new HexCell[height * width];

        for (int z = 0, i = 0; z < height; z++) {
            for (int x = 0; x < width; x++) {
                yield return new WaitForSeconds(0.001f);
                CreateCell(x, z, i++);
            }
        }
    }

    void CreateCell(int x, int z, int i) {
        Vector3 position;
        position.x = (x + z * 0.5f - z / 2) * (HexMatrix.innerRadius * 2f) * 1.1f;
        position.y = 0f;
        position.z = z * (HexMatrix.outerRadius * 1.5f) * 1.1f;

        HexCell cell = cells[i] = Instantiate<HexCell>(cellPrefab);
        cell.transform.SetParent(transform, false);
        cell.transform.localPosition = position;
    }
}
