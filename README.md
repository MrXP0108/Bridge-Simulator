# Bridge-Simulator
One of my engineering mechanics homework is to calculate how materials react to distributed loadings, so I decided to do something silimar to that. This small C# program visualizes the shear force and bending moment of a bridge against a moving car.

## Shear Force and Bending Moments
When a material, like a beam, supports an object, a loading will apply on it. In order to maintain mechanical and rotational equilibrium, the material would develop internal shear force and bending moment. For example, consider a $3$-meter beam, whose rear end attaches to a wall. If an evenly distributed loading $w=5$ kN/m is applying on it, we can easily tell that the internal shear force on the rear end is
$$5\times 3+\text{the weight of beam}$$
kN, and the bending moment on that point is
$$(5\times 3+\text{the weight of beam})\times(3\div 2)$$
kN-m, as long as we consider the whole beam as a system.

When deriving the developed physical properties of a small segment with length $\Delta x$, we see that
$$\frac{dV}{dx}=w\quad\text{and}\quad\frac{dM}{dx}=V$$
hold, where $w$, $V$, $M$ are loading, shear force and bending moment respectively.

By the two equations above, we can draw shear diagram and moment diagram by simply integrating $w$ and $V$.

## The Bridge Model
In our case, a steel "bridge" has two supports at its two ends, so
$$F_l+F_r=\int_{0}^{L}w(x)\text{ }dx$$
and
$$\int_{0}^{L}x\cdot w(x)\text{ }dx=F_r\times L$$
simply hold for such scenario, where $F_l$ and $F_r$ denote the resultant force on the left and right supports.

We also assume that the distributed loading of the car is linear:
$$w(x)=ax+b$$
where $a$ and $b$ are two customized coefficients.

## `BridgeSimulator.exe`
![image](https://user-images.githubusercontent.com/100932226/171025667-94dc8e7a-6df1-49c7-8b58-cd8665d52403.png)

By entering the length and the weight on the two ends of the car, the value of $a$ and $b$ in the previous section are then given.

Once the user enter three valid inputs and hit "Start", the loading on the bridge in the w-x graph will start moving forward, so do the curves in V-x graph and M-x graph. Since the moving of car changes the value of $F_l$ and $F_r$ as well, which are visualized by two red lines at the leftmost and rightmost part of the graph(s), the shape of curves also alters through time.

![Bridge Simulator](https://user-images.githubusercontent.com/100932226/171028945-f5de489b-fa0e-4bc1-b61a-8ce4c67a404e.gif)

Observation of one single diagram is also available:

![image](https://user-images.githubusercontent.com/100932226/171029638-76778e37-8db4-432a-bfce-9353cc96d5ba.png)
