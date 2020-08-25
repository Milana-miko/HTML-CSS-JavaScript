using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class DragAndDrop : MonoBehaviour
{

    public GameObject SelectedPiece;
    int OrdIL = 1;   //Order in Layer
  
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (hit.transform.GetComponent<PieceScripts>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PieceScripts>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OrdIL;
                    OrdIL++;
                }

                    }

            if (Input.GetMouseButtonUp(0))
            {
                
                SelectedPiece.GetComponent<PieceScripts>().Selected = false;
                SelectedPiece = null;

            }
            
            if (SelectedPiece != null)
            {
                SelectedPiece.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }



    }
}
