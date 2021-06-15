
public void RemoveParam(int _id)
{
    for (var i = 0; i < this.allParamObj.list.Count; ++i)
    {
        if (this.allParamObj.list[i].id == _id)
        {
            this.allParamObj.list.RemoveAt(i);
            break;
        }
    }
    this.UpdateParamObject();
}


11111
    222222
    3333
    444
    555
    666
	test