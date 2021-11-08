#include <bits/stdc++.h>
#define fore(i,a,b) for(int i=a,ThxDem=b;i<ThxDem;++i)
#define pb push_back
#define SZ(s) int(s.size())
using namespace std;
typedef long long ll;
typedef pair<int,int> ii;

// link bài: http://olp.hou.edu.vn/problem/treap
// ------here: author: haNguyenBa_ 

typedef struct item *pitem;
int n,q,m; 
vector<int> ans; // ---luu dap an cua bai toan


	//---khởi tạo cây và gắn giá trị cho các phần tử 
struct item 
{
	int pr;  //lưu giá trị ưu tiên của node;
	int val; // lưu giá trị của node;
	int cnt; // key lưu số lượng các phần tử thuộc cây con có gốc là nút đang xét
	bool lz; // giá trị 0-1 của lazy phục vụ việc đảo ngược đoạn
	pitem l,r; // cây con trái và phải
	item(int val): pr(rand()),cnt(1),val(val),l(0),r(0),lz(0) {}
};


	//---hàm thuc hien kĩ thuật lazy propagation
void push(pitem it)
{
	if(it){
		if(it->lz){
			swap(it->l,it->r);
			if(it->l)
				it->l->lz^=true; // kĩ thuật con lắc để đánh 
										//dấu xem có đảo ngược đoạn đó không
										// (true: đảo ngược--- false: không đảo ngược)
			if(it->r)
				it->r->lz^=true;
			it->lz = false;
		}
	}
}


	//---lấy ra số lượng cây con ở cây t
int cnt(pitem t)
{
	return t ? t->cnt : 0;
}

	//---ham update số lượng cây con ở cây t
void upd_cnt(pitem t){ 
	if(t){
		t->cnt=cnt(t->l)+cnt(t->r)+1;
	}
}
	// hàm hợp nhất 2 cây l và r thành cây t
void merge(pitem& t, pitem l, pitem r)
{ 
	push(l);
	push(r);
	if(!l || !r)
		t=l ? l : r;
	else  
		if(l->pr > r->pr)
			merge(l->r,l->r,r), t=l;
	else 
		merge(r->l,l,r->l), t=r;
	upd_cnt(t);
}

// hàm tách cây t thành 2 cây theo key
void split(pitem t, pitem& l, pitem& r, int key){ 
	if(!t)
		{
			l=r=0;
			return;
		}
	push(t);
	if(key <= cnt(t->l))
		split(t->l,l,t->l,key), r=t;
	else 
		split(t->r,t->r,r,key-1-cnt(t->l)), l=t;
	upd_cnt(t);
}
 

//---hàm đệ quy lưu giá trị của các node của cây vào vector ans
// để dẫn xuất đáp án
void Output(pitem t){ 
	if(!t)
		return;
	push(t);
	Output(t->l);
	ans.pb(t->val); // 
	Output(t->r);
}


 // --- hàm xử lý của bài toán: 
void unstoppable()
{

	cin>>n>>q>>m;
	pitem rt=0;  
	fore(i,0,n)
	{
		int x;
		cin>>x; 
		// hợp nhất với cây gốc "rt" để tạo thành cây hoàn chỉnh
		merge(rt,rt,new item(x)); 
	}
	while(q--){
		int t,l,r; 
		cin>>t>>l>>r;
		 l--; r--; // chỉ số bắt đầu từ 0
		if(t==1)
		{
			// rotate
			pitem a,b,c,d;
			split(rt,b,c,r+1);
			split(b,a,b,l);
			split(b,b,d,r-l); 
			merge(b,d,b);
			merge(rt,a,b);
			merge(rt,rt,c);
		}
		else{
			// reverse
			pitem a,b,c;
			split(rt,b,c,r+1);
			split(b,a,b,l);
			b->lz^=1;// điều kiện để reverse
			merge(rt,a,b);
			merge(rt,rt,c);
		}
	}

	Output(rt);

	fore(i,0,m){
		int x;
		cin>>x;
		cout<<ans[x-1]<<" ";
	}
	cout<<endl;
}

// ----Main----
int main()
 {
    ios::sync_with_stdio(0);
    cin.tie(0);
    cout.tie(0);

    unstoppable();


}