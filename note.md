Project đã tổ chức chia Controller, UI, Data khá rõ ràng. Tuy nhiên các phần vẫn bị lẫn với nhau(như Cell, Item), có thể tách rõ hơn để nâng cao thêm performance, dễ dàng debug, maintain. Với một game đơn giản như match 3 thì việc này không ảnh hưởng nhiều nhưng với những game phức tạp hơn thì sẽ ảnh hưởng nhiều hơn.

Project có interface, có kế thừa,... nhưng các lớp Base còn khá đơn giản, chưa tổng quát cho các project khác có thể sử dụng chung.

Project gốc có một số lỗi logic, nhưng mình chưa có thời gian để test kỹ.

Việc đặt tên LevelMove, LevelTime dễ gây hiểu nhầm.

