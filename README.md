# Raycast2D
If your want to click on object and find it You are in the right place. I will show you :D
First of all we have to create empty object and adding collider. Later one more create empty object and adding script.
 LET'S WRİTE CODES !! 

    RaycastHit2D hit;

    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            hit = Physics2D.Raycast(Vector2.zero, Input.mousePosition);
            if(hit!=null)
            {
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }
